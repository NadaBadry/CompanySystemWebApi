using SimpleCompany.Data;
using SimpleCompany.DataAccessLayer.Repository.Contract;

namespace SimpleCompany.DataAccessLayer.Repository
{
	public class GenericRepository<Tentity> : IGenericRepository<Tentity> where Tentity : class
	{
		protected readonly ApplicationDbContext _context;
		protected readonly DbSet<Tentity> _dbSet;
		public GenericRepository(ApplicationDbContext context)
		{
			_context = context;
			_dbSet=_context.Set<Tentity>();
		}

	
		public virtual IEnumerable<Tentity> GetAll()
		{
			return  _dbSet.AsEnumerable();
		}

		public virtual Tentity GetById(int id)
		{
			return _dbSet.Find(id);
		}

		public virtual void Insert(Tentity entity)
		{
			 _dbSet.Add(entity);
		}

		public virtual void Update(Tentity entity)
		{
			_dbSet.Update(entity);
		}
		public virtual  void Delete(int id)
		{
			var entity = GetById(id);
			_dbSet.Remove(entity);
		}
		public virtual void save()
		{
			_context.SaveChanges();
		}

	}
}
