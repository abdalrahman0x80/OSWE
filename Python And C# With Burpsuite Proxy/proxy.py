import requests #pip install requests
response = requests.get("http://testphp.vulnweb.com",proxies={
    "http":"http://127.0.0.1:8080"
},headers={
  "User-Agent":"Mozilla Firefox"  
})
print("-----Content--------")
print(response.text)
print("---------header-----------")
print(response.headers)
print("---------------------------")
print(response.cookies)
print(response.status_code)