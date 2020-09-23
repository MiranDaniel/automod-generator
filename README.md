# Reddit AutoModerator config generator

![commits](https://img.shields.io/github/commit-activity/m/MiranDaniel/automod-generator?style=flat-square)
![issues](https://img.shields.io/github/issues-raw/MiranDaniel/automod-generator?style=flat-square)
![pr](https://img.shields.io/github/issues-pr-raw/MiranDaniel/automod-generator?style=flat-square)

# How to use:
## Windows
1. Download `automoderator-generator-version.exe`
2. Run `automoderator-generator-version.exe`
## Linux 
*Linux is supported from version 1.0.0, older version may to behave correctly.*
1. Download `automoderator-generator-version.exe` and `WineForLinux.sh`
2. Run `WineForLinux.sh` (this will Install Wine-Mono)
3. Run `mono automoderator-generator-version.exe`
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
