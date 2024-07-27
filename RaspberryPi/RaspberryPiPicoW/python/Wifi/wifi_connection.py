import time
import network

#自宅Wi-FiのSSIDとパスワードを入力 
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

# Wi-Fi設定 
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
    print( 'IPアドレス = ' + status[0] )