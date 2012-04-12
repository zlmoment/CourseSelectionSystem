-- phpMyAdmin SQL Dump
-- version 3.4.10.1
-- http://www.phpmyadmin.net
--
-- 主机: localhost
-- 生成日期: 2012 年 04 月 12 日 14:30
-- 服务器版本: 5.5.20
-- PHP 版本: 5.3.10

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- 数据库: `dotnet`
--

-- --------------------------------------------------------

--
-- 表的结构 `tb_college`
--

DROP TABLE IF EXISTS `tb_college`;
CREATE TABLE IF NOT EXISTS `tb_college` (
  `cid` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `cname` varchar(20) NOT NULL DEFAULT '',
  PRIMARY KEY (`cid`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=4 ;

--
-- 转存表中的数据 `tb_college`
--

INSERT INTO `tb_college` (`cid`, `cname`) VALUES
(1, '软件学院'),
(2, '计算机与科学技术学院'),
(3, '经济管理学院');

-- --------------------------------------------------------

--
-- 表的结构 `tb_course`
--

DROP TABLE IF EXISTS `tb_course`;
CREATE TABLE IF NOT EXISTS `tb_course` (
  `cid` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `cname` varchar(20) NOT NULL DEFAULT '',
  `credit` int(1) NOT NULL,
  `week` int(1) NOT NULL,
  `section` int(2) NOT NULL,
  `tid` int(11) NOT NULL,
  `pid` int(11) NOT NULL,
  `precourse` varchar(50) NOT NULL DEFAULT '',
  PRIMARY KEY (`cid`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- 表的结构 `tb_news`
--

DROP TABLE IF EXISTS `tb_news`;
CREATE TABLE IF NOT EXISTS `tb_news` (
  `nid` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `title` varchar(255) NOT NULL DEFAULT '',
  `pubtime` varchar(20) NOT NULL DEFAULT '',
  `content` longtext NOT NULL,
  PRIMARY KEY (`nid`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=18 ;

--
-- 转存表中的数据 `tb_news`
--

INSERT INTO `tb_news` (`nid`, `title`, `pubtime`, `content`) VALUES
(2, '2', '2012/4/10 20:17:48', '2'),
(3, '3', '2012/4/10 20:17:53', '3'),
(12, '1', '2012/4/12 1:50:05', '1'),
(9, '123123213', '2012/4/12 1:30:49', '111'),
(17, 'zz', '2012/4/12 18:00:01', '哈哈哈哈哈哈');

-- --------------------------------------------------------

--
-- 表的结构 `tb_place`
--

DROP TABLE IF EXISTS `tb_place`;
CREATE TABLE IF NOT EXISTS `tb_place` (
  `pid` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `pname` varchar(20) NOT NULL DEFAULT '',
  `parentpid` int(11) NOT NULL,
  PRIMARY KEY (`pid`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- 表的结构 `tb_sc`
--

DROP TABLE IF EXISTS `tb_sc`;
CREATE TABLE IF NOT EXISTS `tb_sc` (
  `id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `sid` int(11) NOT NULL,
  `cid` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- 表的结构 `tb_student`
--

DROP TABLE IF EXISTS `tb_student`;
CREATE TABLE IF NOT EXISTS `tb_student` (
  `sid` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `uid` int(11) NOT NULL,
  `stunum` varchar(10) NOT NULL DEFAULT '',
  `sname` varchar(20) NOT NULL DEFAULT '',
  `gender` tinyint(1) NOT NULL,
  `startyear` varchar(4) NOT NULL DEFAULT '',
  `collegeid` int(11) NOT NULL,
  PRIMARY KEY (`sid`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=3 ;

--
-- 转存表中的数据 `tb_student`
--

INSERT INTO `tb_student` (`sid`, `uid`, `stunum`, `sname`, `gender`, `startyear`, `collegeid`) VALUES
(1, 2, '09301104', '李昭谕', 1, '2009', 1),
(2, 3, '09301097', '黄晓雯', 2, '2009', 1);

-- --------------------------------------------------------

--
-- 表的结构 `tb_system`
--

DROP TABLE IF EXISTS `tb_system`;
CREATE TABLE IF NOT EXISTS `tb_system` (
  `id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `key` varchar(255) NOT NULL DEFAULT '',
  `value` varchar(255) NOT NULL DEFAULT '',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- 表的结构 `tb_teacher`
--

DROP TABLE IF EXISTS `tb_teacher`;
CREATE TABLE IF NOT EXISTS `tb_teacher` (
  `tid` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `uid` int(11) NOT NULL,
  `tname` varchar(20) NOT NULL DEFAULT '',
  `gender` tinyint(1) NOT NULL,
  `birthday` datetime NOT NULL,
  `phone` varchar(15) DEFAULT '',
  PRIMARY KEY (`tid`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- 表的结构 `tb_user`
--

DROP TABLE IF EXISTS `tb_user`;
CREATE TABLE IF NOT EXISTS `tb_user` (
  `uid` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `username` varchar(20) NOT NULL DEFAULT '',
  `password` varchar(20) NOT NULL DEFAULT '',
  `type` int(1) NOT NULL,
  PRIMARY KEY (`uid`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=4 ;

--
-- 转存表中的数据 `tb_user`
--

INSERT INTO `tb_user` (`uid`, `username`, `password`, `type`) VALUES
(1, 'admin', 'nimda', 3),
(2, '09301104', '123456', 1),
(3, '09301097', '123456', 1);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
