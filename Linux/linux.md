## Linux Overview

**Linux** is an operating system family, like Windows or macOS. More specifically, Linux is the **kernel**, which is the core part of the operating system that manages hardware and system resources.

A complete Linux system usually includes:

```text
Linux kernel + system tools + shell + package manager + desktop/server software
```

Examples of Linux-based operating systems are called **distributions**, or **distros**.

Common Linux distros:

| Distro                   | Common Use                        |
| ------------------------ | --------------------------------- |
| Ubuntu                   | Beginner-friendly, desktop/server |
| Debian                   | Stable servers                    |
| Fedora                   | Modern Linux features             |
| Arch Linux               | Advanced/custom setup             |
| Kali Linux               | Cybersecurity tools               |
| Raspberry Pi OS          | Raspberry Pi projects             |
| Red Hat Enterprise Linux | Enterprise servers                |

---

## What Linux Is Used For

Linux is used in many areas:

| Area             | Example                               |
| ---------------- | ------------------------------------- |
| Servers          | Websites, databases, cloud apps       |
| Embedded systems | Routers, medical devices, IoT         |
| Android          | Android uses the Linux kernel         |
| DevOps           | Docker, CI/CD, cloud deployment       |
| Cybersecurity    | Kali Linux, penetration testing       |
| Programming      | C, C++, Python, Java, web development |
| Supercomputers   | Most supercomputers run Linux         |

For your interests, Linux is especially useful for **embedded systems, CAN Bus, USB, I²C, drivers, networking, and DevOps**.

---

## Basic Linux Architecture

```text
Applications
   ↓
Shell / GUI
   ↓
System Libraries
   ↓
Linux Kernel
   ↓
Hardware
```

### 1. Applications

These are programs you use, such as:

```text
Firefox, VS Code, Docker, Python, GCC, MySQL
```

### 2. Shell

The shell is a command-line interface where you type commands.

Common shells:

```text
bash
zsh
fish
```

Example:

```bash
ls
cd Documents
mkdir project
```

### 3. System Libraries

Libraries help programs communicate with the kernel.

Example:

```text
glibc
```

### 4. Kernel

The kernel manages:

```text
CPU
memory
files
processes
network
drivers
hardware devices
```

### 5. Hardware

Physical components:

```text
CPU, RAM, disk, keyboard, USB devices, CAN adapter, sensors
```

---

## Linux vs Windows

| Linux                        | Windows                        |
| ---------------------------- | ------------------------------ |
| Open-source                  | Closed-source                  |
| Common for servers/devices   | Common for desktops            |
| Strong command-line tools    | GUI-focused                    |
| Highly customizable          | Less customizable              |
| Many distributions           | One main OS family             |
| Great for programming/devops | Great for general users/gaming |

---

## Important Linux Concepts

### 1. Terminal

The terminal is where you type commands.

Example:

```bash
pwd
```

Shows your current folder.

```bash
ls
```

Lists files.

```bash
cd folderName
```

Moves into a folder.

---

### 2. File System

Linux organizes files like a tree.

```text
/
├── home
├── etc
├── bin
├── usr
├── var
├── tmp
└── dev
```

Important folders:

| Folder  | Meaning                               |
| ------- | ------------------------------------- |
| `/`     | Root directory                        |
| `/home` | User files                            |
| `/etc`  | Configuration files                   |
| `/bin`  | Essential commands                    |
| `/usr`  | Installed software                    |
| `/var`  | Logs, databases, changing files       |
| `/tmp`  | Temporary files                       |
| `/dev`  | Devices like USB, disks, serial ports |

Example:

```bash
/home/hudson/Documents/project
```

is like:

```text
C:\Users\Hudson\Documents\project
```

on Windows.

---

### 3. Users and Permissions

Linux is multi-user. Files have owners and permissions.

Example:

```bash
ls -l
```

Output:

```text
-rw-r--r-- 1 hudson hudson 1200 file.txt
```

Permissions:

| Symbol | Meaning |
| ------ | ------- |
| `r`    | read    |
| `w`    | write   |
| `x`    | execute |

Example:

```bash
chmod +x script.sh
```

Makes a script executable.

Run with:

```bash
./script.sh
```

---

### 4. Root and `sudo`

`root` is the administrator user.

Instead of logging in as root, you usually use:

```bash
sudo command
```

Example:

```bash
sudo apt update
```

This runs the command with admin permissions.

---

### 5. Package Manager

A package manager installs software.

Ubuntu/Debian use:

```bash
apt
```

Examples:

```bash
sudo apt update
sudo apt install git
sudo apt install python3
sudo apt install build-essential
```

Fedora uses:

```bash
dnf
```

Arch uses:

```bash
pacman
```

---

## Essential Linux Commands

### Navigation

```bash
pwd
```

Show current directory.

```bash
ls
```

List files.

```bash
cd folder
```

Go into a folder.

```bash
cd ..
```

Go back one folder.

```bash
cd ~
```

Go to home folder.

---

### File and Folder Commands

```bash
mkdir myfolder
```

Create folder.

```bash
touch file.txt
```

Create empty file.

```bash
cp file.txt backup.txt
```

Copy file.

```bash
mv file.txt newname.txt
```

Rename or move file.

```bash
rm file.txt
```

Delete file.

```bash
rm -r folder
```

Delete folder.

---

### View File Content

```bash
cat file.txt
```

Show whole file.

```bash
less file.txt
```

View large file.

```bash
head file.txt
```

Show first lines.

```bash
tail file.txt
```

Show last lines.

```bash
tail -f app.log
```

Follow logs in real time.

---

### Search

```bash
grep "error" app.log
```

Search text inside a file.

```bash
find . -name "*.java"
```

Find Java files in current folder.

---

### Processes

```bash
ps
```

Show running processes.

```bash
top
```

Live process monitor.

```bash
kill PID
```

Stop a process.

Example:

```bash
kill 1234
```

---

### Networking

```bash
ping google.com
```

Test connection.

```bash
curl http://localhost:8080
```

Send HTTP request.

```bash
ip addr
```

Show network interfaces.

```bash
ss -tulpn
```

Show open ports.

---

## Linux for Programming

Linux is popular for software development because it has strong tools.

Common tools:

```bash
git
gcc
g++
make
cmake
python3
node
npm
java
maven
docker
```

Example Java setup:

```bash
sudo apt install openjdk-21-jdk maven
```

Example Node setup:

```bash
sudo apt install nodejs npm
```

Example C/C++ setup:

```bash
sudo apt install build-essential
```

---

## Linux for Embedded Systems

Linux is very important in embedded systems.

Examples:

```text
Raspberry Pi
BeagleBone
Jetson Nano
routers
medical devices
cars
industrial controllers
```

Embedded Linux lets you work with hardware interfaces like:

```text
GPIO
UART
I²C
SPI
USB
CAN Bus
Bluetooth
Wi-Fi
```

Example device files:

```text
/dev/ttyUSB0
/dev/i2c-1
/dev/can0
```

In Linux, hardware often appears as files inside `/dev`.

Example:

```bash
ls /dev
```

You might see:

```text
ttyUSB0
sda
i2c-1
can0
```

---

## Linux and CAN Bus

For CAN Bus, Linux often uses **SocketCAN**.

SocketCAN allows CAN Bus devices to behave like network interfaces.

Example:

```bash
ip link
```

You may see:

```text
can0
```

To set up CAN:

```bash
sudo ip link set can0 type can bitrate 500000
sudo ip link set can0 up
```

To view CAN messages:

```bash
candump can0
```

To send a CAN message:

```bash
cansend can0 123#DEADBEEF
```

This is useful for automotive, robotics, industrial, and medical-device communication projects.

---

## Linux and I²C

I²C is used for short-distance communication between chips and sensors.

Example tools:

```bash
sudo apt install i2c-tools
```

Scan I²C devices:

```bash
i2cdetect -y 1
```

Read/write I²C registers:

```bash
i2cget
i2cset
```

Common use cases:

```text
temperature sensors
accelerometers
OLED displays
RTC clock modules
```

---

## Linux and USB

Linux can detect USB devices using:

```bash
lsusb
```

Kernel logs for USB devices:

```bash
dmesg
```

Example:

```bash
dmesg | grep USB
```

Serial USB devices often appear as:

```text
/dev/ttyUSB0
/dev/ttyACM0
```

You can communicate with them using:

```bash
screen
minicom
python serial
```

---

## Linux and DevOps

Linux is also heavily used in DevOps.

Common tools:

```text
Docker
Kubernetes
Nginx
SSH
GitHub Actions runners
cloud servers
CI/CD pipelines
```

Useful commands:

```bash
ssh user@server
```

Connect to a remote server.

```bash
scp file.txt user@server:/home/user/
```

Copy file to server.

```bash
docker ps
```

Show running containers.

```bash
docker logs container_name
```

Show container logs.

---

## Important Linux Skills to Learn

For your software/embedded goals, learn in this order:

```text
1. Terminal basics
2. File system and permissions
3. Package managers
4. Git on Linux
5. Shell scripting
6. Processes and services
7. Networking commands
8. Docker on Linux
9. Serial communication
10. I²C, USB, CAN Bus tools
11. Basic kernel/device driver concepts
```

---

## Simple Learning Roadmap

### Beginner

Learn:

```text
terminal
files/folders
permissions
installing software
basic bash commands
```

Practice commands:

```bash
pwd
ls
cd
mkdir
touch
cp
mv
rm
cat
grep
find
chmod
sudo
```

---

### Intermediate

Learn:

```text
bash scripting
processes
services
logs
networking
SSH
Docker
```

Practice:

```bash
ps aux
top
systemctl
journalctl
curl
ping
ssh
docker ps
docker logs
```

---

### Embedded/Linux Hardware Level

Learn:

```text
/dev devices
USB serial
I²C tools
SocketCAN
GPIO
udev rules
kernel modules
device tree basics
```

Practice:

```bash
lsusb
dmesg
ls /dev
i2cdetect
candump
cansend
```

---

## Simple Example: Linux Workflow

Imagine you are running a backend app.

```bash
git clone https://github.com/example/project.git
cd project
sudo apt install openjdk-21-jdk maven
mvn test
mvn spring-boot:run
```

Check if the app is running:

```bash
curl http://localhost:8080
```

Check logs:

```bash
tail -f app.log
```

Check port:

```bash
ss -tulpn
```

---

## Simple Summary

Linux is:

```text
an operating system family built around the Linux kernel
```

It is important because it powers:

```text
servers
cloud systems
Android
embedded devices
routers
IoT
automotive systems
medical devices
developer tools
```

The most important beginner skill is the **terminal**.

For your goals, Linux is especially useful because it connects software with real hardware:

```text
USB
I²C
CAN Bus
serial ports
drivers
networking
Docker
servers
embedded systems
```
