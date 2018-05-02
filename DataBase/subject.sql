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

 Date: 01/05/2018 01:43:12
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for subject
-- ----------------------------
DROP TABLE IF EXISTS `subject`;
CREATE TABLE `subject`  (
  `subject_id` varchar(100) CHARACTER SET gb2312 COLLATE gb2312_chinese_ci NOT NULL,
  `subject_name` varchar(255) CHARACTER SET gb2312 COLLATE gb2312_chinese_ci NULL DEFAULT NULL,
  PRIMARY KEY (`subject_id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = gb2312 COLLATE = gb2312_chinese_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of subject
-- ----------------------------
INSERT INTO `subject` VALUES ('A001', '英语视听说');
INSERT INTO `subject` VALUES ('A002', '英文写作');
INSERT INTO `subject` VALUES ('B001', '书法鉴赏');
INSERT INTO `subject` VALUES ('C001', '市场营销导论');
INSERT INTO `subject` VALUES ('C002', '知识产权保护');
INSERT INTO `subject` VALUES ('D001', '计算机导论');
INSERT INTO `subject` VALUES ('D002', '数据结构');

SET FOREIGN_KEY_CHECKS = 1;
