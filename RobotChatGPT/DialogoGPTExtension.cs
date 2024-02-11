using OpenAI;
using OpenAI.Managers;
using OpenAI.ObjectModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotChatGPT
{
    public static class DialogoGPTExtension
    {
        private static OpenAIService _service = new OpenAIService(new OpenAiOptions() { ApiKey = "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" });

        public static async Task<string> GetMessageText(this DialogoGPT dialogo)
        {
            var completion = await _service.Completions.CreateCompletion(new OpenAI.ObjectModels.RequestModels.CompletionCreateRequest()
            {
                Prompt = dialogo.Message,
                Model = Models.TextDavinciV3
            });

            if (completion.Successful)
            {
                var choices = completion.Choices.FirstOrDefault();
                if (choices != null) { return choices.Text; }

                return "Nenhum resposta encontrada.";
            }

            return $"{completion.Error.Code}: {completion.Error.Message}";
        }


        public static async Task<string> GetMessageImage(this DialogoGPT dialogo)
        {
            var image = await _service.Image.CreateImage(new OpenAI.ObjectModels.RequestModels.ImageCreateRequest()
            {
                Prompt = dialogo.Message,
                N = 1,
                Size = StaticValues.ImageStatics.Size.Size256,
                ResponseFormat = StaticValues.ImageStatics.ResponseFormat.Url
            });

            if (image.Successful)
            {
                var choices = image.Results.FirstOrDefault();
                if (choices != null) { return choices.Url; }

                return "Nenhum resposta encontrada.";
            }

            return $"{image.Error.Code}: {image.Error.Message}";
        }

    }
}
