using Azure;
using Dapper;
using Domain.Person;
using Infrastructure.Interface;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class PersonRepository :  ConnectionDb.ConnectionDb, IPersonRepository
    {
       // readonly SqlConnection conn;
        public PersonRepository(IConfiguration configuration) : base(configuration)
        {
           // conn = GetConnection();
        }

        public async Task<string> deleteAsync(int Id)
        {
            using (var conn = GetConnection())
            {
                await conn.OpenAsync();
                String sql = "delete from person where id=" + Id;
                try
                {
                    var result = conn.Query<Person>(sql);
                    return "Delete Success";
                }
                catch (Exception ex)
                {
                    return "Delete failed";
                    throw ex;
                }
            }
        }

        public async Task<IEnumerable<Person>> FindAllAsync()
        {
            using (var conn = GetConnection())
            {
                await conn.OpenAsync();
                String sql = "select * from person";
                var result = conn.Query<Person>(sql);
                return result;
            }
          
        }
        
        public async Task<IEnumerable<Person>> getbyIDAsync(int Id)
        {
            using (var conn = GetConnection())
            {
                await conn.OpenAsync();
                String sql = "select * from person where id="+Id;
                var result = conn.Query<Person>(sql);
                return result;
            }
        }

        public async Task<String> insertAsync(String Name,int Age)
        {
            using (var conn = GetConnection())
            {
                await conn.OpenAsync();
                String sql = "insert into person(name,age) values (N'" + Name + "'," + Age + ")";
                try
                {
                    var result = conn.Query<Person>(sql);
                    return "Insert Success";
                }
                catch (Exception ex)
                {
                    return "Insert failed";
                    throw ex;
                }
            }
        }

        public async Task<string> updateAsync(Person p)
        {
            using (var conn = GetConnection())
            {
                await conn.OpenAsync();
                String sql = "update person set name=N'"+p.Name+"',age="+p.Age+ " where id=" +  p.Id;
                try
                {
                    var result = conn.Query<Person>(sql);
                    return "Update Success";
                }
                catch (Exception ex)
                {
                    return "Update failed";
                    throw ex;
                }
            }
        }
    }
}
