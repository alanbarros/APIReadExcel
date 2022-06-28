using Microsoft.AspNetCore.Mvc;
using SpreadSheetParser.Models;

namespace APIReadExcel.Controllers;

[ApiController]
[Route("[controller]")]
public class UploadDocumentController : ControllerBase
{
    private readonly ILogger<UploadDocumentController> _logger;

    public UploadDocumentController(ILogger<UploadDocumentController> logger)
    {
        _logger = logger;
    }

    [HttpPost("UploadExcel")]
    public IActionResult UploadExcelContract(IFormFile file)
    {
        _logger.LogInformation(file.FileName);

        List<SheetContract> contracts = SheetReader.ReadStream<SheetContract>(file.OpenReadStream());

        return new OkObjectResult(contracts);
    }
}
