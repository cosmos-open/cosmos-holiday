# Holiday Definition Docs

## Types of Holiday

+ Public：公共节假日
+ Commemoration：纪念日
+ Tradition：传统节假日
+ Lunar：农历节气
+ Religion：宗教
+ School：学校
+ Bank：银行
+ Propaganda：宣传日

## Rule for Holiday's I18N Code

0. 代码不包含 day，除非当不包含 day 时严重偏离原意（如 May Day）
0. 当不包含 Day、但前面单词包含后缀 `'s` 或 `s'` 的，应当移除（如 New Year's Day 的代码为 `new_year`），但注意保留复数形式
    - 如果带有年份的，则保留 day
0. 当使用 `of` 前后倒置时，代码应恢复顺序，除非为复杂短语（如多次包含 of 的）
0. 代码应使用英语 26 个字母和数字，其他字符请转换为相似形制的英语字母
    - 仅能使用下划线 `_` 分割
    - 不包含其他字符
0. 包含 `saint`、`st.` 的，省略