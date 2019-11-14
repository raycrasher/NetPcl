using System;
using System.Collections.Generic;
using System.Linq;

namespace NetPcl.Models
{
    public class TestRepository: IRepository
    {


        private readonly Dictionary<Type, Tuple<Dictionary<int, object>, int>> _objects = new Dictionary<Type, Tuple<Dictionary<int, object>, int>>();

        public IEnumerable<Factor> SearchFactors(string term){
            return Get<Factor>().Where(f=>f.Name.Contains(term) || f.Tags.Contains(term));
        }

        public void SaveFactor(Factor factor) {
            Save(factor);
        }

        public void SaveSheet(TestSheet sheet) {
            Save(sheet);
        }

        public TestSheet GetSheet(int id){
            return Get<TestSheet>(id);
        }

        public void SaveSuite(TestSuite suite){
            Save(suite);
        }

        public TestSuite GetSuite(int id){
            return Get<TestSuite>(id);
        }

        public IEnumerable<TestSuite> GetSuites(int numItemsPerPage, int page){
            return Get<TestSuite>().Skip(numItemsPerPage*page).Take(numItemsPerPage);
        }

        private IEnumerable<T> Get<T>() where T: DbObject {
            if(!_objects.TryGetValue(typeof(T), out var kvd)){
                return Enumerable.Empty<T>();
            }
            return kvd.Item1.Values.Cast<T>();
        }

        private T Get<T>(int id) where T: DbObject {
            if(!_objects.TryGetValue(typeof(T), out var kvd)){
                return null;
            }
            
            if(kvd.Item1.TryGetValue(id, out var v)){
                return v as T;
            }
            else return null;
        }

        private T Save<T>(T obj) where T : DbObject {
            if(!_objects.TryGetValue(typeof(T), out var kvd)){
                kvd = Tuple.Create(new Dictionary<int, object>(), 1);
                _objects[typeof(T)] = kvd;
            }
            if(obj.Id <= 0) {
                // new object
                int id = kvd.Item2;
                _objects[typeof(T)]=Tuple.Create(kvd.Item1,id+1);
                obj.Id = id;
                kvd.Item1[id] = obj;
            }
            else {
                kvd.Item1[obj.Id] = obj;
            }
            return obj;
        }

    }

}