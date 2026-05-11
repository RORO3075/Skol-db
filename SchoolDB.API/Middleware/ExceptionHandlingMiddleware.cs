namespace SchoolDB.Middleware;
/// <summary>
/// Wraps the whole pipeline in a try/catch.
//
// If anything throws anywhere in the app:
// - Catches it here
//     - Logs the error
//     - Returns a clean JSON response instead of a crash page
//
// {
//     "status": 500,
//     "message": "Something went wrong",
//     "detail": "..."
// }
//
// Without this, unhandled exceptions show ugly stack traces to the caller.
/// </summary>
public class ExceptionHandlingMiddleware
{
    
}