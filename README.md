# Reddit AutoModerator config Generator (RAG)

Application created for generating config for Reddit AutoModerator. Supports almost all used functions (70+). Created to help people learn how to create AutoModerator config.

---
### Download new version: [b0.0.4](https://github.com/MiranDaniel/automod-generator/releases/latest)

---


# How to use:
## Windows
1. Download `automoderator-generator-version.exe`
2. Run `automoderator-generator-version.exe`
## Linux 
*Linux is supported from version 1.0.0, older versions may not behave correctly*
1. Download `automoderator-generator-version.exe` and `WineForLinux.sh`
2. Run `WineForLinux.sh` (this will Install Wine-Mono)
3. Run `mono automoderator-generator-version.exe`
4. Enable "Linux Mode" in the app settings

(This method uses Wine compatibility layer for Windows)
## MacOS
There is no support for MacOS and we are not planning on adding it.

---
## https://discord.gg/JhNeVSq (Discord support server)
---
# Supported functions:

## Checks
**Types**
```
any
submission
comment
text submission
link submission
crosspost submission
poll submission
gallery submission
```
**Search Checks**
```
body
title
domain
url
flair_text
flair_css_class
flair_template_id
crosspost_title
```

**User Checks**
```
is_gold
is_submitter
is_contributor
is_moderator
```

**Modifiers**
```
(regex)
(includes-word)
(includes)
(starts-with)
(ends-with)
(full-exact)
(full-text)
(case-sensitive)
```

**Standards**
```
image hosting sites
direct image links
video hosting sites
streaming sites
crowdfunding sites
meme generator sites
facebook links
amazon affiliate links
```

**K/A Checks**
```
comment_karma
post_karma
combined_karma
account_age
```

## Actions
**Action**
```
remove
approve
spam
filter
report
```

```
action_reason
report_reason
```

```
set_sticky
set_nsfw
set_spoiler
set_locked
set_contest_mode
set_original_content
```
**Modmail**
```
modmail_subject
modmail
```

## Other

```
moderators_exempt
priority
```

```
reports
body_longer_than
body_shorter_than
```

---
Special thanks to everyone that helped this project, by adding code, sharing this repo or just supporting us in the development. Thank you!

![I love yall](https://img.shields.io/badge/Powered%20by-%3C3-red?style=flat-square&logo=flat-square)
