#!/bin/bash

trap "exit" SIGINT
mkdir /assets
mkdir /assets/html
while :
do
    cat /usr/bin/app.html > /assets/html/app.html
    sleep 10
done