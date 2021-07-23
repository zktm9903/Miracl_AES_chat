# Miracl library를 이용한 암호화 채팅

- client = c# winform으로 구현  
- server = node.js (express)  
- cryption program = c (miracl)  
***
- __miracl library(visual c++)는 window에서 구동__ dfd
     - https://github.com/zktm9903/Miracl_window



- cryption program 출력값   
  - ex)AES_exe E hello (암호화)  
  - ->@165 18 18 231 66 11 36 220 133 67 213 91 42 71 8 183 @  
  - ex)AES_exe E 165 18 18 231 66 11 36 220 133 67 213 91 42 71 8 183 (복호화)  
  - ->@hello @

  - '@'는 데이터 파싱을 위한 구분문자  (c#에서 처리)



- client(c#)와 server(node.js)의 통신은 socket.io 사용  
  - c# socket io package  
    - EngineIoClientDotNet(0.9.22)
    - SocketIOSharp(2.0.3) (https://github.com/uhm0311/SocketIOSharp)

***
사용법  

DotNetClient\aesClient\aesClient\Form1.cs  

Form1.cs
```js
        //CMD에 보낼 명령어를 입력
            pro.StandardInput.Write(@"cd D:\\바탕화면의_라이브러리\\Desktop\\miracl_aes_chat\\cryptionC\\AES\\x64\\Debug" + Environment.NewLine); //경로 설정
```
- AES.exe 까지의 경로 설정  

- node js (express) socket.js 서버 구동 (app.js x)
***
__구동__  
- client
<img src=./IMG/client.PNG width="600">   

- server  
<img src=./IMG/server.PNG> 


