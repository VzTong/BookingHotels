using App.Data.Entities.Base;

namespace App.Data.Repositories
{
	public partial class GenericRepository
	{
		public virtual async Task UpdateAsync<TEntity>(TEntity entity) where TEntity : AppEntityBase
		{
			this.BeforeUpdate(entity);
			_db.Update(entity);
			await _db.SaveChangesAsync();
		}

		public virtual async Task UpdateAsync<TEntity>(IEnumerable<TEntity> entities) where TEntity : AppEntityBase
		{
			var len = entities.Count();
			for (int i = 0; i < len; i++)
			{
				this.BeforeUpdate(entities.ElementAt(i));
			}
			_db.UpdateRange(entities);
			await _db.SaveChangesAsync();
		}
	}
}