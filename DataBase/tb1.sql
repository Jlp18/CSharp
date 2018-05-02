/*
 Navicat Premium Data Transfer

 Source Server         : MySQL18
 Source Server Type    : MySQL
 Source Server Version : 50560
 Source Host           : localhost:3307
 Source Schema         : test

 Target Server Type    : MySQL
 Target Server Version : 50560
 File Encoding         : 65001

 Date: 01/05/2018 01:43:19
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for tb1
-- ----------------------------
DROP TABLE IF EXISTS `tb1`;
CREATE TABLE `tb1`  (
  `username` varchar(20) CHARACTER SET gb2312 COLLATE gb2312_chinese_ci NOT NULL,
  `password` varchar(10) CHARACTER SET gb2312 COLLATE gb2312_chinese_ci NULL DEFAULT NULL,
  PRIMARY KEY (`username`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = gb2312 COLLATE = gb2312_chinese_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of tb1
-- ----------------------------
INSERT INTO `tb1` VALUES ('John', '123456');

SET FOREIGN_KEY_CHECKS = 1;
