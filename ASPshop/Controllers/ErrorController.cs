using ASPshop.Errors;
using Microsoft.AspNetCore.Mvc;

namespace ASPshop.Controllers;

[Route("errors/{code}")]
public class ErrorController : BaseApiController
{
  public IActionResult Error(int code)
  {
    return new ObjectResult(new ApiResponse(code));
  }  
}