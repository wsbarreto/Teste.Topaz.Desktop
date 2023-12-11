﻿using System.Data;
using System.Data.Common;
using Teste.Topaz.Desktop.Data.Context;
using Teste.Topaz.Desktop.Domain.Interface.Repository;

namespace Teste.Topaz.Desktop.Data.Repository;

public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
{
    protected readonly DataContext _dataContext;

    public BaseRepository(DataContext dataContext) => _dataContext = dataContext;

    public async Task InsertAsync(TEntity entity)
    {
        try
        {
            await _dataContext.Set<TEntity>().AddAsync(entity);
            await _dataContext.SaveChangesAsync();
        }
        catch (DataException ex) { throw (ex); }
        catch (DbException ex) { throw (ex); }
        catch (Exception ex) { throw (ex); }
    }

    public async Task InsertRangeAsync(IList<TEntity> entity)
    {
        try
        {
            await _dataContext.Set<TEntity>().AddRangeAsync(entity);
            await _dataContext.SaveChangesAsync();
        }
        catch (DataException ex) { throw (ex); }
        catch (DbException ex) { throw (ex); }
        catch (Exception ex) { throw (ex); }
    }

    public async Task UpdateAsync(TEntity entity)
    {
        try
        {
            _dataContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _dataContext.SaveChangesAsync();
        }
        catch (DataException ex) { throw (ex); }
        catch (DbException ex) { throw (ex); }
        catch (Exception ex) { throw (ex); }
    }

    public async Task DeleteAsync(TEntity entity)
    {
        try
        {
            if (entity is null)
                return;

            _dataContext.Set<TEntity>().Remove(entity);
            _dataContext.SaveChanges();
        }
        catch (DataException ex) { throw (ex); }
        catch (DbException ex) { throw (ex); }
        catch (Exception ex) { throw (ex); }
    }

    public async Task<IEnumerable<TEntity>> FindAllAsync()
    {
        try
        {
            var lista = _dataContext.Set<TEntity>().ToList();
            return lista;
        }
        catch (DataException ex) { throw (ex); }
        catch (DbException ex) { throw (ex); }
        catch (Exception ex) { throw (ex); }
    }

    public async Task<TEntity> FindByIdAsync(Guid id)
    {
        try
        {
            return await _dataContext.Set<TEntity>().FindAsync(id);
        }
        catch (DataException ex) { throw (ex); }
        catch (DbException ex) { throw (ex); }
        catch (Exception ex) { throw (ex); }
    }

    public async Task<TEntity> FindByPredicateAsync(Predicate<TEntity> predicate)
    {
        try
        {
            return await _dataContext.Set<TEntity>().FindAsync(predicate);
        }
        catch (DataException ex) { throw (ex); }
        catch (DbException ex) { throw (ex); }
        catch (Exception ex) { throw (ex); }
    }

    public async Task SaveChangesAsync() =>
        await _dataContext.SaveChangesAsync();
}
