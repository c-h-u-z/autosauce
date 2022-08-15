# Git steps

## 1- Before you do some work (or if dev is updated)

```git checkout dev``` so that you are in dev branch

```git pull``` to pull the latest version of dev

```git checkout (your branch name - this is case sensitive)```

This puts you into your own branch, but it needs to get the latest dev, so

```git merge dev``` 

Now you are working with the latest changes and only modifying your branch

## 2 - After you have made any changes

```git add .``` will add stage all your changes to be committed

```git commit -m ("Added stuff")``` to commit your changes

```git push``` to push your changes

Then, go to [GitHub](https://github.com/c-h-u-z/autosauce) and make a pull request. This will update the dev branch with your changes. 

Make sure to repeat step 1 if you continue to make changes

## Common problems

to-do

