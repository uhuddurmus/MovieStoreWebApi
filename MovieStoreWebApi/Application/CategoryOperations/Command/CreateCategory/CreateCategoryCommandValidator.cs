using FluentValidation;

namespace MovieStoreWebApi.CategoryOperations.CreateCategory
{
    public class CreateCategoryCommandValidator : AbstractValidator<CreateCategoryCommand>
    {
        public CreateCategoryCommandValidator()
        {
            RuleFor(command => command.Model.CategoryName).NotEmpty().MinimumLength(4);

        }
    }
}