using Microsoft.EntityFrameworkCore;
using ToDoList.Data.Models;

namespace ToDoList.Data
{
    public class ToDoTaskRepository : IToDoTaskRepository
    {
        private ToDoListContext _toDoListContext;

        public ToDoTaskRepository(ToDoListContext context)
        {
            _toDoListContext = context;
        }
        public void Add(ToDoTask toDoTask)
        {
            _toDoListContext.Add(toDoTask);
            _toDoListContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var deleteTask = _toDoListContext.Tasks.FirstOrDefault(x => x.Id == id);
            _toDoListContext.Tasks.Remove(deleteTask);
            _toDoListContext.SaveChanges();
        }

        public List<ToDoTask> GetAll()
        {
            return _toDoListContext.Tasks.Include(t => t.Owner).Include(t => t.Category).ToList();
        }

        public ToDoTask GetById(int id)
        {
            return _toDoListContext.Tasks.Include(t => t.Owner).Include(t => t.Category).FirstOrDefault(x => x.Id == id);
        }

        public void Update(ToDoTask toDoTask)
        {
            _toDoListContext.Entry(toDoTask).State = EntityState.Modified;
            _toDoListContext.SaveChanges();
        }
    }
}
