# EventStoreSample

# Run EventStore in docker with --mem-db option

the documentaion is here 
https://hub.docker.com/r/eventstore/eventstore/
https://eventstore.org/docs/server/command-line-arguments/index.html

```
docker run --name es -d -p 2113:2113 -p 1113:1113 -e EVENTSTORE_MEM_DB=True eventstore/eventstore
```

# Web

Go to browser and open http://127.0.0.1:2113/ . Username is admin and the password is changeit 



# run he project and try using postman to make a post request 

```
Method: Post
url: https://localhost:44318/api/Customers

{
    "FirstName": "Younes",
    "LastName": "Baghaei Moghaddam"
}

```


# Result

in EventStore home, in Stream Browser page you cann see the events




