#!/bin/bash

directory = $1
old_username = "ShmyholRoman"
old_email = "romanshm@tahometer.com"

if [ ! -d ${directory} ]
	then
	echo "Error: Directory ${directory} DOES NOT exists."
	mkdir directory
	cd directory
else
	cd directory
fi

git init
git config --global user.name = ${old_username}
git config --global user.email = ${old_email}

echo "Username = ${old_username}, Email = ${old_email}"

read -p "Do you want change username or email? (y/n)" answear

if [ $answear = "y"]:
then
	read -p "Input your username: " new_username
	if [! -z "$new_username"]
	then
		git config --global user.name = ${new_username}
	fi

	read -p "Input your email: " new_email
	if [! -z "$new_email"]
	then
		git config --global user.email = ${new_email}
	fi
fi

echo "text=auto" > .gitattributes
git add .gitattributes
git commit -m "Initial setup"

