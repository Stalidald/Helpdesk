using HelpdeskBackEnd.Data;
using HelpdeskBackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace HelpdeskBackEnd.Controllers
{
    [ApiController]
    public abstract class BaseController<TEntity, TController> : ControllerBase  where TEntity : BaseModel 
    {
        private ILogger<TController> _logger;
        protected ILogger<TController> Logger => _logger ??= HttpContext.RequestServices.GetService<ILogger<TController>>();

        protected DbSet<TEntity> _dbSet { get; set; }

        protected readonly HelpdeskDbContext _context;

        public BaseController(ILogger<TController> logger, HelpdeskDbContext context)
        {
            _logger = logger;
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        [HttpGet]
        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        [HttpGet("{id}")]
        public virtual async Task<TEntity> GetAsync(long id)
        {
            return await _dbSet.Where(e => e.Id == id).FirstOrDefaultAsync();
        }

        // Hard delete
        [HttpDelete("{id}")]
        public virtual async Task DeleteAsync(long id)
        {
            var entity = await _dbSet.Where(e => e.Id == id).FirstOrDefaultAsync();
            _dbSet.Remove(entity);

            await _context.SaveChangesAsync();
        }

        [HttpPost]
        public virtual async Task<TEntity> CreateAsync(TEntity entity)
        {
            entity.CreatedOn = DateTime.Now;

            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        [HttpPut]
        public virtual async Task<TEntity> UpdateAsync(TEntity entity)
        {
            entity.UpdatedOn = DateTime.UtcNow;

            _dbSet.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

    }
}
