using App.Data.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace App.Data.Repositories
{
	public partial class GenericRepository
	{
		public virtual async Task DeleteAsync(AppEntityBase entity)
		{
			var now = DateTime.Now;
			entity.DeletedDate = now;
			if (_httpContext != null)
			{
				entity.UpdatedBy = CurrentUserId();
			}
			_db.Update(entity);
			await _db.SaveChangesAsync();
		}

		public virtual async Task DeleteAsync<TEntity>(int id) where TEntity : AppEntityBase
		{
			var tableName = GetTableName<TEntity>();
			int? updateUserId = null;
			if (_httpContext != null)
			{
				updateUserId = CurrentUserId();
			}
			var query = $"UPDATE {tableName} SET DeletedDate = GETDATE(), UpdatedBy = {updateUserId} WHERE Id = {id}";
			LogDebugQuery(query);
			await _db.Database.ExecuteSqlRawAsync(query);
		}

		public virtual async Task DeleteAsync<TEntity>(List<int> ids) where TEntity : AppEntityBase
		{
			var tableName = GetTableName<TEntity>();
			int? updateUserId = null;
			if (_httpContext != null)
			{
				updateUserId = CurrentUserId();
			}
			if (ids.Count > 0)
			{
				var query = $"UPDATE {tableName} SET DeletedDate = GETDATE(), UpdatedBy = {updateUserId} WHERE Id IN ({String.Join(',', ids)})";
				LogDebugQuery(query);
				await _db.Database.ExecuteSqlRawAsync(query);
			}
		}

		public virtual async Task HardDeleteAsync<TEntity>(int id) where TEntity : AppEntityBase
		{
			var tableName = GetTableName<TEntity>();
			var deleteQuery = $"DELETE FROM {tableName} WHERE Id = {id}";
			LogDebugQuery(deleteQuery);
			await _db.Database.ExecuteSqlRawAsync(deleteQuery);
		}

		public virtual async Task HardDeleteAsync<TEntity>(IEnumerable<int> ids) where TEntity : AppEntityBase
		{
			if (ids == null || !ids.Any())
			{
				throw new Exception("Danh sách ID rỗng");
			}
			var tableName = GetTableName<TEntity>();
			var deleteQuery = $"DELETE FROM {tableName} WHERE Id IN ({string.Join(',', ids)})";
			LogDebugQuery(deleteQuery);
			await _db.Database.ExecuteSqlRawAsync(deleteQuery);
		}
	}
}