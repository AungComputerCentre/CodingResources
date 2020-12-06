import os

os.system("wget -qO- https://packages.microsoft.com/keys/microsoft.asc | gpg --dearmor > packages.microsoft.gpg")
os.system("sudo install -o root -g root -m 644 packages.microsoft.gpg /etc/apt/trusted.gpg.d/")
os.system("""sudo sh -c 'echo "deb [arch=amd64 signed-by=/etc/apt/trusted.gpg.d/packages.microsoft.gpg] https://packages.microsoft.com/repos/vscode stable main" > /etc/apt/sources.list.d/vscode.list'""")
os.system("sudo apt-get install apt-transport-https")
os.system("sudo apt-get update")

os.system("sudo apt-get install code")

os.system("sudo code")
