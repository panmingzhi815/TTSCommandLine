using SpeechLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TTSCommandLine
{
    class Program
    {
        static void Main(string[] args)
        {
            SpVoice voice = new SpVoice();
            voice.Voice = voice.GetVoices().Item(0);

            if (args.Length == 1)
            {
                Console.WriteLine("语音合成内容:" + args[0]);
                voice.Speak(args[0]);
                return;
            }
            else
            {
                Console.WriteLine("请输入语音合成内容：");
                string speakVoice = Console.ReadLine();
                if (speakVoice.Length > 0)
                {
                    voice.Speak(speakVoice);
                }
            }
        }
    }
}
