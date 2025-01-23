using Microsoft.Extensions.Logging;

var logger = LoggerFactory.Create(builder => builder.AddConsole()).CreateLogger<Program>();
logger.LogInformation("Hello, World!");
//logger.LogInformation("Attempting hot reload...");
