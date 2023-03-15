using ToDoList.Data.Models;

namespace ToDoList.Data
{
    public interface IToDoTaskRepository
    {
        public void Add(ToDoTask toDoTask);
        public void Update(ToDoTask toDoTask);
        public ToDoTask GetById(int id);
        public List<ToDoTask> GetAll();
        public void Delete(int id);

    }
}
