from machine import  ADC
import time
import network
import socket

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

html = """
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <title>Pico W</title>
    <style>
        body {
            font-family: Arial, Helvetica, sans-serif;
            background-color: #e0e0e0;
            color: #333;
            text-align: center;
            padding: 50px;
        }
        h1 {
            color: #008080;
            border-bottom: 1px solid #333;
            padding-bottom: 10px;
        }
        .temp {
            font-size: 2.5em;
            color: #333;
            background-color: #ffc107;
            padding: 10px;
            border-radius: 5px;
            display: inline-block;
            margin-top: 20px;
        }
    </style>
</head>
<body>
    <h1>Pico W</h1>
    <p>現在の温度:</p>
    <p class="temp">%s &#8451;</p>
</body>
</html>
"""

sensor_temp = ADC(4)
conversion_factor = 3.3 / (65535)

# ソケットを開く
addr = socket.getaddrinfo('0.0.0.0', 80)[0][-1]
s = socket.socket()
s.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
s.bind(addr)
s.listen(1)
print('listening on', addr)

# 接続を待ち受け、クライアントを処理する
while True:
    try:
        # クライアントからの接続を受け付ける
        cl, addr = s.accept()
        print('client connected from', addr)
        # クライアントからのリクエストを受け取る
        request = cl.recv(1024)

        # 温度センサ読み取り
        ADC_voltage = sensor_temp.read_u16() * conversion_factor
        temp = 27 - (ADC_voltage - 0.706) / 0.001721
        temp = round(temp, 1)
        temp = str(temp)

        # レスポンスを作成し送信する
        response = html % ("Picoの温度: " + str(temp))
        cl.send('HTTP/1.0 200 OK\r\nContent-type: text/html\r\n\r\n' + response)

        cl.close()
    except OSError as e:
        print("socket error:", e)
        cl.close()
        print("connection closed")



        conn, addr = s.accept()
        print('接続:', addr)
        request = conn.recv(1024)
        print('Request:', request)
        temp_reading = sensor_temp.read_u16() * conversion_factor
        temp = 27 - (temp_reading - 0.706) / 0.001721
        response = httml % temp
        conn.send(response)
        conn.close()

