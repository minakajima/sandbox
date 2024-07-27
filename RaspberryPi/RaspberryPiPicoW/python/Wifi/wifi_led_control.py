# -*- coding: utf-8 -*-
import time
import network
import socket
from machine import Pin

#Wi-Fiへの接続
def connect_to_wifi(ssid, password):
    wlan = network.WLAN(network.STA_IF)
    wlan.active(True)
    wlan.connect(ssid, password)

    max_wait = 10
    while max_wait > 0:
        if wlan.status() < 0 or wlan.status() >= 3:
            break
        max_wait -= 1
        print('接続待ち...')
        time.sleep(1)

    if wlan.status() != 3:
        raise RuntimeError('ネットワーク接続失敗')
    else:
        print('接続完了')
        status = wlan.ifconfig()
        print('IPアドレス = ' + status[0])
        
# 自宅Wi-FiのSSIDとパスワードを入力
config_file_path = "/wifi_config.txt"
try:
  with open(config_file_path, 'r', encoding='utf-8') as file:
    config = file.read().splitlines()
    ssid = config[0]
    password = config[1]
  print("ssid: " + ssid)
#  print("password: xxxxxx" + password)
  print("password: xxxxxx")
except FileNotFoundError:
 print("Wi-Fi設定ファイルが見つかりません: ", config_file_path)
 raise

# Wi-Fiに接続
connect_to_wifi(ssid, password)

# HTMLでウェブページを作成
html = """
<!DOCTYPE html>
<html>
<head>
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <style>
    html {
      font-family: Helvetica;
      text-align: center;
    }
    button {
      color: white;
      padding: 15px 32px;
      font-size: 16px;
      margin: 4px 2px;
      cursor: pointer;
      border: none;
      border-radius: 15px;
    }
    .green { background-color: #f44336; }
    .red { background-color: #00BFFF; }
    button, form { display: inline-block; text-align: center; }
  </style>
</head>
<body>
  <h1>Raspberry Pi Pico W</h1>
  <form>
    <button class="green" name="led" value="on" type="submit">LED ON</button>
    <button class="red" name="led" value="off" type="submit">LED OFF</button>
  </form>
  <p>%s</p>
</body>
</html>
"""

# LEDのピンを設定
led = Pin("LED", Pin.OUT)

# LEDの状態を初期化
ledState = "LED State Unknown"

# ソケットの設定を開始
addr = socket.getaddrinfo("0.0.0.0", 80)[0][-1]
s = socket.socket()
s.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
s.bind(addr)
s.listen(1)
print("listening on", addr)

# クライアントからの接続を待つ
while True:
    try:
        # クライアントからの接続を受け付ける
        cl, addr = s.accept()
        print("client connected from", addr)
        # クライアントからのリクエストを受け取る
        request = cl.recv(1024)
        request = str(request)
        # リクエストから'led=on'と'led=off'の位置を検索
        led_on = request.find("led=on")
        led_off = request.find("led=off")

        # 'led=on'や'led=off'の文字列の位置によりLEDを制御
        if led_on == 8:
            print("led on")
            led.on()  # LEDを点灯
        if led_off == 8:
            print("led off")
            led.off()  # LEDを消灯

        # LEDの現在の状態を設定
        ledState = "LED is OFF" if led.value() == 0 else "LED is ON"

        # レスポンスを作成し、クライアントに送信       
        response = "HTTP/1.0 200 OK\r\nContent-type: text/html\r\n\r\n" + (html % ledState)
        cl.send(response)
        cl.close()

    # エラーが発生した場合、クライアントとの接続を閉じる
    except OSError as e:
        cl.close()
        print("connection closed")