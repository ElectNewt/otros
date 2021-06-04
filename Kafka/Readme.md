# Kafka

## Anonymous connection

`docker-compose-anonymous.yaml` configuration to use more than one broker with kafka with anonymous conifugration.

it includes: 
- Zookeper
- Kafka broker 1 (localhost:9093)
- Kafka broker 2 (localhost:9094)
- Kafka broker 3 (localhost:9095)
- Kafdrop (localhost:9090)

remember to change the name to `docker-compose.yaml` to allow it to be executed.

## Username and password connection
`docker-compose-userpass.yaml` configuration to use username and password, it can be combined with anonymous brokers

it includes: 
- Zookeper
- Kafka broker 1 (localhost:9096)
- Kafdrop (localhost:9090)

remember to change the name to `docker-compose.yaml` to allow it to be executed.
