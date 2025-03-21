using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace Rhibhus.Reports.API.Controllers
{
	[ApiExplorerSettings(IgnoreApi = true)]
	[Route("sign")]
	[ApiController]
	public class SignatureController : ControllerBase
	{
		[HttpPost]
		public IActionResult SaveSignature([FromBody] SignatureDto signatureDto)
		{
			try
			{
				if (string.IsNullOrEmpty(signatureDto.Signature))
				{
					return BadRequest(new { Message = "Invalid signature data" });
				}

				string base64Data = signatureDto.Signature.Replace("data:image/png;base64,", "");
				byte[] imageBytes = Convert.FromBase64String(base64Data);
				string directoryPath = Path.Combine("wwwroot", "signatures");

				// Ensure directory exists
				if (!Directory.Exists(directoryPath))
				{
					Directory.CreateDirectory(directoryPath);
				}

				string fileName = "signature.png";
				string filePath = Path.Combine(directoryPath, fileName);

				System.IO.File.WriteAllBytes(filePath, imageBytes);

				return Ok(new { Message = "Signature saved successfully", Path = $"/signatures/{fileName}" });
			}
			catch (Exception ex)
			{
				return BadRequest(new { Message = "Error saving signature", Error = ex.Message });
			}
		}
	}

	public class SignatureDto
	{
		public string Signature { get; set; }
	}
}
