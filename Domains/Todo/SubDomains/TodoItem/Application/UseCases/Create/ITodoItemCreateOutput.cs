using Aviant.Application.UseCases;

namespace CleanDDDArchitecture.Domains.Todo.SubDomains.TodoItem.Application.UseCases.Create;

public interface ITodoItemCreateOutput : IUseCaseOutput
{
    public void Ok(object? @object);

    public void Invalid(string message);
}
