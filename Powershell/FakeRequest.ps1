# seznam moznych voleb
$resultList = $true, $false, $null

# nahodne generovane volby
$data = @{
    UID = [Guid]::NewGuid()
    Result = $resultList[(Get-Random -Maximum ([array]$resultList).Count)]
}

# RAW data paket
#$data = "{ ""Uid"": ""195A39D5-5ADA-4BE3-819F-B5AC76B22DCD"", ""Result"": ""true"" }"

# WebRequest
#Invoke-WebRequest -Uri "http://voter.lorenzo.cz/api/vote/create/" -Body $data -Method Post | Out-Null
#Invoke-WebRequest -Uri "http://localhost:49854/api/vote/create/" -Body $data -Method Post | Out-Null # 01_MVC
#Invoke-WebRequest -Uri "http://localhost:52547/api/vote/create/" -Body $data -Method Post | Out-Null # 02_Grafika
#Invoke-WebRequest -Uri "http://localhost:53577/api/vote/create/" -Body $data -Method Post | Out-Null # 03_Grafy
Invoke-WebRequest -Uri "http://localhost:58921/api/vote/create/" -Body $data -Method Post | Out-Null # 04_Komplet

# print dat
$data