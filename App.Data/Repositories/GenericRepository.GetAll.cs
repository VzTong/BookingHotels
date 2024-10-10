using App.Data.Entities.Base;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace App.Data.Repositories
{
	public partial class GenericRepository
	{
		public virtual IOrderedQueryable<TEntity> GetAll<TEntity>(bool selectFromTrash = false)
			where TEntity : AppEntityBase
		{
			var defaultWhere = GetDefaultWhereExpr<TEntity>(selectFromTrash);
			var query = _db.Set<TEntity>()
						.AsNoTracking()
						.Where(defaultWhere)
						.OrderByDescending(m => m.DisplayOrder)
						.ThenByDescending(m => m.Id);
			LogDebugQuery(query);
			return query;
		}

		public virtual IQueryable<TViewModel> GetAll<TEntity, TViewModel>(
			MapperConfiguration mapperConfig,
			bool selectFromTrash = false,
			Expression<Func<TEntity, bool>> where = null)
			where TEntity : AppEntityBase
		{
			var defaultWhere = GetDefaultWhereExpr<TEntity>(selectFromTrash);
			var query = _db.Set<TEntity>()
						.AsNoTracking()
						.Where(defaultWhere);
			if (where != null)
			{
				query = query.Where(where);
			}
			var query2 = query.OrderByDescending(m => m.DisplayOrder)
						.ThenByDescending(m => m.Id)
						.ProjectTo<TViewModel>(mapperConfig);
			LogDebugQuery(query2);
			return query2;
		}

		public virtual IQueryable<TEntity> GetAll<TEntity>(
			Expression<Func<TEntity, bool>> where,
			bool selectFromTrash = false)
			where TEntity : AppEntityBase
		{
			var defaultWhere = GetDefaultWhereExpr<TEntity>(selectFromTrash);
			var query = _db.Set<TEntity>()
						.AsNoTracking()
						.Where(defaultWhere)
						.Where(where)
						.OrderByDescending(m => m.DisplayOrder)
						.ThenByDescending(m => m.Id);
			LogDebugQuery(query);
			return query;
		}

		public virtual IQueryable<TViewModel> GetAll<TEntity, TViewModel>(
			Expression<Func<TEntity, bool>> where,
			Expression<Func<TEntity, TViewModel>> selector,
			bool selectFromTrash = false)
			where TEntity : AppEntityBase
		{
			var defaultWhere = GetDefaultWhereExpr<TEntity>(selectFromTrash);
			var query = _db.Set<TEntity>()
						.AsNoTracking()
						.Where(defaultWhere)
						.Where(where)
						.OrderByDescending(m => m.DisplayOrder)
						.ThenByDescending(m => m.Id)
						.Select(selector);
			LogDebugQuery(query);
			return query;
		}
	}
}