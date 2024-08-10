import time
import network
import ntptime

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

#NTPサーバーとして"time.cloudflare.com"を指定
ntptime.host = "time.cloudflare.com"

# 時間の同期を試みる
try:
    # NTPサーバーから取得した時刻でPico WのRTCを同期
    ntptime.settime()
    print("NTP時間取得成功")
    print(time.localtime())
except:
    print("NTP時間取得失敗")
    raise

# 世界標準時に9時間を足して日本時間に変換
tm = time.localtime(time.time() + 9 * 60 * 60)

# 現在の日付と時刻「年/月/日 時:分:秒」を表示
print("{0}/{1:02d}/{2:02d} {3:02d}:{4:02d}:{5:02d}".format(tm[0], tm[1], tm[2], tm[3], tm[4], tm[5]))


