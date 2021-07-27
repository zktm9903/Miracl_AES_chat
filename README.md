# Miracl library를 이용한 암호화 채팅

- client = c# winform으로 구현  
- server = node.js (express)  
- cryption program = c (miracl)  
***
- __miracl library(visual c++)는 window에서 구동__
     - https://github.com/zktm9903/Miracl_window



- cryption program 출력값   
  - ex)AES_exe E hello (암호화)  
  - ->@165 18 18 231 66 11 36 220 133 67 213 91 42 71 8 183 @  
  - ex)AES_exe E 165 18 18 231 66 11 36 220 133 67 213 91 42 71 8 183 (복호화)  
  - ->@hello @

  - '@'는 데이터 파싱을 위한 구분문자  (c#에서 처리)



- client(c#)와 server(node.js)의 통신은 socket.io 사용  


***
__설정__  

DotNetClient\aesClient\aesClient\Form1.cs  

Form1.cs
```js
        //CMD에 보낼 명령어를 입력
            pro.StandardInput.Write(@"cd D:\\바탕화면의_라이브러리\\Desktop\\miracl_aes_chat\\cryptionC\\AES\\x64\\Debug" + Environment.NewLine); //경로 설정
```
- AES.exe 까지의 경로 설정  

***
__구동하는 법__

- node js 설치 (https://nodejs.org/ko/)
- socket.js 파일이 있는 위치까지 터미널을 통해 이동
  - ex) cd C:\경로\test
- socket.js 실행 (app.js x)
  - ex) node socket.js
- chat 클라이언트 실행
  - 경로\miracl_aes_chat\DotNetClient\aesClient\aesClient\bin\Debug\netcoreapp3.1\aesClient.exe 실행

***

__개발 환경__

- window 10
- node js v14.17.3
- .NET Framework 4.8
- c# socket io package  
  - EngineIoClientDotNet(0.9.22)
  - SocketIOSharp(2.0.3) (https://github.com/uhm0311/SocketIOSharp)

***
__구동__  
- client
<img src=./IMG/client.PNG width="600">   

- server  
<img src=./IMG/server.PNG> 


