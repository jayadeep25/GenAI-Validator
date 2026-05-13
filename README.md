A lightweight ASP.NET Core MVC application that allows users to interact with multiple Large Language Models (LLMs) like **ChatGPT (OpenAI)** and **Google Gemini** through a unified chat interface.


 Features

-Minimalistic chat UI
-Multi-provider support (OpenAI & Gemini)
-Dynamic provider selection
-Clean service-based architecture
-API key management via configuration


UI Preview

- Simple and clean interface
- Dropdown to select LLM provider
- Chat window for conversation


Tech Stack

- .NET 8 (ASP.NET Core MVC)
- C#
- HttpClient for API calls
- JSON serialization (System.Text.Json)


Setup Instructions

1. Clone the repository

   git clone https://github.com/jayadeep25/LLM-Validator.git
   cd LLM-Validator.sln


2. Add API Keys
   Update appsettings.json with your keys


   "LlmSettings": {
     "OpenAIKey": "YOUR_OPENAI_API_KEY",
      "GeminiKey": "YOUR_GEMINI_API_KEY"

3. Run the application
