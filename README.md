<h1>Password Pwn</h1>
Password Pwn helps get current user credentials by popping a fake Windows lock screen, all output is sent to Console which works perfect for Cobalt Strike. It is written in C# to allow for direct execution via memory injection using techniques such as execute-assembly found in Cobalt Strike or others, this method prevents the executable from ever touching disk. It is NOT intended to be compilled and run locally on a device.

<h1>Works</h1>
Single/Multiple Monitors
Windows 10
Working Password Pwn

<h1>How to</h1>
<p>Compile SharpLocker from source via VisualStudio etc</p>
<p>Within a Cobalt Strike implant run execute-assembly C:/{location of exe}</p>
<p>Pray and wait for creds</p>
