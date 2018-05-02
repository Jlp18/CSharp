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

 Date: 01/05/2018 01:43:05
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for student
-- ----------------------------
DROP TABLE IF EXISTS `student`;
CREATE TABLE `student`  (
  `No` int(10) NOT NULL AUTO_INCREMENT,
  `student_id` varchar(255) CHARACTER SET gb2312 COLLATE gb2312_chinese_ci NOT NULL,
  `student_name` varchar(255) CHARACTER SET gb2312 COLLATE gb2312_chinese_ci NOT NULL,
  `sex` enum('男','女') CHARACTER SET gb2312 COLLATE gb2312_chinese_ci NULL DEFAULT NULL,
  `student_class` varchar(255) CHARACTER SET gb2312 COLLATE gb2312_chinese_ci NOT NULL,
  PRIMARY KEY (`No`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 3 CHARACTER SET = gb2312 COLLATE = gb2312_chinese_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of student
-- ----------------------------
INSERT INTO `student` VALUES (1, '150405201', '张磊', '男', '计算机1502班');
INSERT INTO `student` VALUES (2, '150405202', '呼伦', '男', '计算机1502班');

SET FOREIGN_KEY_CHECKS = 1;
