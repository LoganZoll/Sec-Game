In order to import the project into Godot theres a couple steps to do

1. Git clone the repository

2. Open Godot and click the import tab. Select the cloned folder

In order to edit or view different branches

1. git switch "wanted branch" | pressing tab should autofill

2. git pull

Git may complain about this if you made an edit but didn't push it.

You can either push to the branch you were on or

git reset --hard HEAD

to go back to the latest commit in that branch
