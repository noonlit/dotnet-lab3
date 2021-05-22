using FluentValidation;
using Lab3.Data;
using Lab3.ViewModels;

namespace Lab3.Validators
{
	public class CommentValidator: AbstractValidator<CommentViewModel>
	{
        private readonly ApplicationDbContext _context;

        public CommentValidator(ApplicationDbContext context)
        {
            _context = context;
            RuleFor(c => c.Text).MinimumLength(10);
            RuleFor(c => c.MovieId).NotNull();
        }
    }
}
