import time
import network
import urequests as requests

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

# web APIのURLを作成
city_id = "230020" # 豊橋   
# 地域IDは以下のURLから調べることができる
# https://weather.tsukumijima.net/primary_area.xml


# 天気予防APIのURL組み立て
url = "https://weather.tsukumijima.net/api/forecast/city/" + city_id

# 指定したURLから天気予報を取得
response = requests.get(url)
weather_data = response.json() # データをpythonの辞書型に変換

# 今日の降水確率を取得 0:今日 1:明日 2:明後日('T12_18'は12時から18時の降水確率)
rain_probability = weather_data['forecasts'][0]['chanceOfRain']['T12_18']

# 降水確率が取れない場合の処理
if rain_probability == "--%":
   print("no value") # 降水確率が取得できない場合のメッセージ
else:
   print("降水確率 {}" .format(rain_probability)) # 降水確率を表示
