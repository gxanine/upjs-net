# NOTE: upjs-net is still in development and is not ready to use


<p align="center">
  <a href="https://github.com/gilnicki/upjs/">
    <img
      alt="Node.js"
      src="https://github.com//gilnicki/upjs-net/blob/main/res/logo.svg?raw=true"
      width="400"
    />
  </a>
</p>

# Simple .Net Framework wrapper library for using [upjs](https://github.com/gilnicki/upjs)

**upjs-net** is a .Net framework wrapper for [upjs](https://github.com/gilnicki/upjs) - simple app for downloading updates for your program.

#### This README file is still in development too

### Reference the dll in your .Net Framework (>= **4.0**) project to:
- Execute upjs commands with `Execute(string args)` (**`args`** is just what you would pass after calling upjs.exe directly)
It returns a string which is the output of upjs process
- Run full Github upgrade with `GithubFull(string user, string repo, string current_version)` **(Returns bool)**
- Run upjs clear with `Clear()`
- Run upjs rem-old with `RemOld()`
- You can also run `RestartSelf(Process mainProcess)` after a successful upgrade this will stop the old and start the new version of your program like a boss 🥇 

### Note: you need the [upjs.exe](https://github.com/gilnicki/upjs) in your main directory!

---

With ❤ and ☕ by Greg

---
This program is open-source and distributed under the MIT License, see *LICENSE.md* for details.
