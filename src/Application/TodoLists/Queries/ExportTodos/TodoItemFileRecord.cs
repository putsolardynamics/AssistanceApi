using RestApiTemplate.Application.Common.Mappings;
using RestApiTemplate.Domain.Entities;

namespace RestApiTemplate.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
