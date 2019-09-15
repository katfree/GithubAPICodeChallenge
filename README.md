# New Hire Code Test
This coding challenge will be sent to potential new hires to test their debugging skills. 

# What the project does
* Uses the Github API to pull top repos.
* Loops through the top repos and grab the URLs.
* Encrypts the URLs and stores them in a text file, only if that URL does not already exist (no duplicates).
* The Github API will be called three times. In the View you will see a boolean if the text file contains any duplicates for the three API calls.

# What you need to do
* This program is broken in several places. Step through and find where the program is broken.
* The expected result is all three API call duplicate checks return false.

Remember there should be no duplicates of any URLs in the text file!

# How to deliver 
* Clone down the solution and copy the QuaverCodeChallenge folder into your own GitHub repo.
* Send us the link (email implementation@QuaverMusic.com) to your GitHub solution when complete.

# Debugging Process
*First, I opened the solution and ran the program to see where it was at. I saw the program didn't run so I opened the Github controller file in the solution. Upon inspection, I saw it didn't run because the views in the controller were't properly named, so I moved the GithubRepo view file to a Folder name Github in the Views folder and renamed the function accordingly. 

*Then, I sucessfully ran the program and saw the homepage of the application wasn't the Github controller by default and made a mental note to fix that later. After navigating to ~/github/GitHubTopRepos I ran the Github API call. The program broke at the jsonitemslist because the code wasn't actually accessing the json information I then stepped through the program to look at the parsed json content to see where to access the Github repo Urls. 

*After, I was able to sucessfully run the Github API call. When it was completed I saw that two of the three calls returned true which was not what I wanted per the instructions. I stepped through and saw that when the url was being written to the file, it was comparing an ecrypted Url to an unencrypted Url so of course there would be duplicates! I then changed it so they were both encrypted as they were being compared. Afterwards, the program ran sucessfully with three false return values. 

*Now that the program ran successfully, I went back into the Startup.cs file and made the Github controller the default controller. I also went back into the Github controller and specified the routing for both functions. 
