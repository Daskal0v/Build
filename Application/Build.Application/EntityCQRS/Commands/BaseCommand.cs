namespace Build.Application.EntityCQRS.Commands;

using MediatR;

/// <summary>
/// Base class for commands.
/// </summary>
/// <typeparam name="T">Command type.</typeparam>
public abstract class BaseCommand<T> : IRequest<T>
{
    protected BaseCommand ()
    {
    }
}

