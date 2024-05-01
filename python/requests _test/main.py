import requests

url = "https://www.example.com"  # Replace with the URL of the web page you want to fetch

response = requests.get(url)

if response.status_code == 200:
    content = response.text
    print(content)
else:
    print("Failed to fetch the web page. Status code:", response.status_code)