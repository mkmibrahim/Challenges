using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using Microsoft.CognitiveServices.Speech.Translation;
using Microsoft.Extensions.Configuration;

namespace _02_AI_Speech_Translation
{
    internal class Program
    {
        private static SpeechConfig speechConfig;
        private static SpeechTranslationConfig translationConfig;

        static async Task Main(string[] args)
        {
            try
            {
                // Get cofig settings from AppSettings
                IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
                IConfigurationRoot configuration = builder.Build();
                string cogSvcKey = configuration["CognitiveServiceKey"];
                string cogSvcRegion = configuration["CognitiveServiceRegion"];

                //Configurare translation
                translationConfig = SpeechTranslationConfig.FromSubscription(cogSvcKey, cogSvcRegion);
                translationConfig.SpeechRecognitionLanguage = "en-US";
                translationConfig.AddTargetLanguage("fr");
                translationConfig.AddTargetLanguage("es");
                translationConfig.AddTargetLanguage("nl");
                Console.WriteLine($"Ready to translate from {translationConfig.SpeechRecognitionLanguage}");

                // configure speech
                speechConfig = SpeechConfig.FromSubscription(cogSvcKey, cogSvcRegion);

                string targetLanguage = "";
                while (targetLanguage != "quit")
                {
                    Console.WriteLine("\nEnter a target language\n fr = French\n es = Spanich\n nl = Dutch\n Enter anything else to stop\n");
                    targetLanguage= Console.ReadLine().ToLower();
                    if (translationConfig.TargetLanguages.Contains(targetLanguage))
                        await Translate(targetLanguage);
                    else
                        targetLanguage= "quit";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static async Task Translate(string targetLanguage)
        {
            string translation = "";

            // Translate speech
            using AudioConfig audioConfig = AudioConfig.FromDefaultMicrophoneInput();
            using TranslationRecognizer translator = new TranslationRecognizer(translationConfig, audioConfig);
            Console.WriteLine("Speak now...");
            TranslationRecognitionResult result = await translator.RecognizeOnceAsync();
            Console.WriteLine($"Translating '{result.Text}'");
            translation = result.Translations[targetLanguage];
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(translation);


            // Synthesize translation
            var voices = new Dictionary<string, string>
            {
                ["fr"] = "fr-FR-HenriNeural",
                ["es"] = "es-ES-ElviraNeural",
                ["nl"] = "nl-NL-ColetteNeural"
            };
            speechConfig.SpeechSynthesisVoiceName = voices[targetLanguage];
            using SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer(speechConfig);
            SpeechSynthesisResult speak = await speechSynthesizer.SpeakTextAsync(translation);
            if (speak.Reason != ResultReason.SynthesizingAudioCompleted)
                Console.WriteLine(speak.Reason);
        }
    }
}
