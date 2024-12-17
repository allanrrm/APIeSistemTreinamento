using APIeSistemTreinamento.Data;
using APIeSistemTreinamento.Interface;
using APIeSistemTreinamento.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Collections.Generic;

namespace APIeSistemTreinamento.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected readonly ApiDbContext _dbContext;
        protected readonly DbSet<TEntity> _dbSet;

        public Repository(ApiDbContext db)
        {
            _dbContext = db;
            _dbSet = db.Set<TEntity>();
            
        }

        public async Task<IEnumerable<TEntity>> BuscarTodos()
        {
            var empresas = await _dbSet.ToListAsync();
            return empresas;
        }

        public async Task<ActionResult<TEntity>> BuscarPorId(int id)
        {
            var cfop = await _dbSet.FirstOrDefaultAsync(p => p.Id == id);
            return cfop;
        }

        public virtual async Task Adicionar(TEntity entity)
        {
            _dbSet.Add(entity);
            await SaveChanges();
        }

        public virtual async Task Atualizar(TEntity entity)
        {
            _dbSet.Update(entity);
            await SaveChanges();

        }

        public virtual async Task Remover(int id)
        {
            TEntity entity = await _dbSet.SingleOrDefaultAsync(p => p.Id == id);
            _dbSet.Remove(entity);
            await SaveChanges();

        }

        public async Task<int> SaveChanges()
        {
            return await _dbContext.SaveChangesAsync();
        }
      


        public void Dispose()
        {
            _dbContext?.Dispose();
        }
    }
}
