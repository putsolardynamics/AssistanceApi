using RestApiTemplate.Application.TodoLists.Queries.ExportTodos;

namespace RestApiTemplate.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
