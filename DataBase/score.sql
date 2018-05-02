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

 Date: 01/05/2018 01:42:50
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for score
-- ----------------------------
DROP TABLE IF EXISTS `score`;
CREATE TABLE `score`  (
  `subject_id` varchar(100) CHARACTER SET gb2312 COLLATE gb2312_chinese_ci NOT NULL,
  `subject_name` varchar(255) CHARACTER SET gb2312 COLLATE gb2312_chinese_ci NOT NULL,
  `student_id` varchar(255) CHARACTER SET gb2312 COLLATE gb2312_chinese_ci NOT NULL,
  `student_name` varchar(255) CHARACTER SET gb2312 COLLATE gb2312_chinese_ci NOT NULL,
  `student_class` varchar(255) CHARACTER SET gb2312 COLLATE gb2312_chinese_ci NOT NULL,
  `score` double(255, 1) NOT NULL
) ENGINE = InnoDB CHARACTER SET = gb2312 COLLATE = gb2312_chinese_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of score
-- ----------------------------
INSERT INTO `score` VALUES ('A001', '英语视听说', '150405201', '张磊', '计算机1502', 100.0);
INSERT INTO `score` VALUES ('A001', '英语视听说', '150405202', '呼伦', '计算机1502', 90.0);
INSERT INTO `score` VALUES ('A001', '英语视听说', '150405203', '王先志', '计算机1502', 80.0);
INSERT INTO `score` VALUES ('A001', '英语视听说', '150405303', '谢浩林', '计算机1503', 70.0);
INSERT INTO `score` VALUES ('B001', '书法鉴赏', '150405105', '程明浩', '计算机1501', 100.0);
INSERT INTO `score` VALUES ('B001', '书法鉴赏', '150405115', '赵家亿', '计算机1501', 60.0);
INSERT INTO `score` VALUES ('B001', '书法鉴赏', '150405130', '刘星', '计算机1501', 40.0);
INSERT INTO `score` VALUES ('B001', '书法鉴赏', '150405201', '张磊', '计算机1502', 80.0);

SET FOREIGN_KEY_CHECKS = 1;
