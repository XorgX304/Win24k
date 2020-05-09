# Win24k

    Windows 10 reverse PowerShell exploit.

# Summary

* [Building](#building)
* [Attacking](#attacking)

# Building

## Requirements

```
mono
```

## Building

> make

# Attacking

## Listener

**NOTE:** It's recommended to use [ThorCat listener](https://github.com/enty8080/ThorCat), but you can use NetCat.

* ThorCat

> ./thorcat -l <local_host> -p <local_port>

* NetCat

> nc -l <local_port>

## Exploit

**1.** Write `local_host` and `local_port` to `exploit.cs`.

**2.** Build exploit and execute on target system.
