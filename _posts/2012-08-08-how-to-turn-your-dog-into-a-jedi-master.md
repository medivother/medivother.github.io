---
date: 2022-10-12 12:26:40
layout: post
title: Homework 2
subtitle: In this article we will go deep into the concept of distribution.
description: Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
image: https://res.cloudinary.com/dm7h7e8xj/image/upload/v1559821648/theme8_knvabs.jpg
optimized_image: https://res.cloudinary.com/dm7h7e8xj/image/upload/c_scale,w_380/v1559821648/theme8_knvabs.jpg
category: distributions
tags:
  - jedi
  - doggo
  - starwars
author: mranderson
---

<script type="text/javascript" id="MathJax-script" async
  src="https://cdn.jsdelivr.net/npm/mathjax@3/es5/tex-mml-chtml.js">
</script>
<script>
  MathJax = {
    tex: {
      inlineMath: [['$', '$']]
    }
  };
</script>


# Distributions
## Definition of statistical distribution
A statistical distribution, describes how values are distributed for a field. In other words, the statistical distribution shows which values are common and uncommon.

But how do we obtain a distribution from a given dataset? A data matrix is made of rows, each of them being a unit ui, and of columns, which are the attributes x1, …, xn of the entities in dataset. To make it easier to explain this concept, let’s say that our dataset is made of 80 people, and some of its attributes are “color of eyes”, “heigth”, “weigth”, etc..


|    | $x_1$ ... | $x_j$ ... |  ... $x_k$ |
|----|--------|--------|---------|
| $u_1$ |        |        |         |
| $u_i$ |        | $x_{i,j}$   |         |
| $u_n$ |        |        |         |


Let’s focus on only one attribute at the moment, picking the “color of the eyes” one. Just by reading through the column and counting how many people have blue eyes, we are going to obtain something called relative frequency of that value in our attribute. Intuitively, this is the ratio of the actual number of favourable events to the total. To be more precise, for each value of an attribute xj we can compute its relative frequency, in order to create another table:


|            | Color of eyes |
|------------|---------------|
| blue eyes  | 8/80          |
| brown eyes | 62/80         |
| green eyes | 10/80         |


univarite distribution of the attribute “color of the eyes”


This is the (univariate) distribution of the color of the eyes of the people in the dataset. The term ‘distribution’ is used in descriptive as well as inductive statistics. In descriptive statistics it stands for the (absolute or relative) frequency of the values of a variable. A frequency distribution describes statistical data. We described it in the table above. In inductive statistics, it describes the distribution of probability of individual values for different variables. Mathematically, this describes the distribution function and the density function. 

## Univariate and multivariate distributions
In statistics, a univariate distribution is a probability distribution of only one random variable. This is in contrast to a multivariate distribution, the probability distribution of a random vector (consisting of multiple random variables).

An example of univariate distribution is the one about the color of the eyes that we saw above: we picked up a random variable and calculated it’s relative frequency to obtain the distribution of the color of the eyes in the dataset. Whereas when we want to calculate the multivariate distribution, we want to know how many entities have the same values for the selected attributes: in other words, the joint frequency.

## Conditional and marginal distribution
A conditional distribution is a distribution of values for one variable that exists when you specify the values of other variables. This type of distribution allows you to assess the dispersal of your variable of interest under specific conditions, hence the name.

That might sound a bit complex, but the idea is straightforward.

Suppose you’re selling computers, and you record the type of computer and gender for each sale. Now imagine that you want to assess the dispersal of computer types for only female customers. That’s an example of a conditional distribution. We’re conditioning computer types on the gender variable value of female.


![hw2](https://user-images.githubusercontent.com/99642347/205963218-93614740-4e10-4ded-83de-1cda1cb169aa.png)


On the other hand, a marginal distribution is a distribution of values for one variable that ignores a more extensive set of related variables in a dataset. That definition sounds a bit convoluted, but the concept is simple. The idea is that when you have a larger set of related variables that you collected for a study, you might want to focus on one of them to answer a specific question.

Imagine the same context as descripted before: we have a computer shop where we sell differen types of products and we also record the gender of our costumers. Now suppose that while you measured both variables, you want to know the distribution of computer types without factoring in gender—that’s a marginal distribution.



![hw2_1](https://user-images.githubusercontent.com/99642347/205963660-8c2be28d-4f49-4885-8093-e698945b5b2d.png)



# Application

You can download the application from <a href="https://drive.google.com/file/d/1MlnRAU86TOOmTjpPfzjIUeBk6hXnM4Uz/view?usp=sharing" download>here</a>.

<video src="https://user-images.githubusercontent.com/99642347/205968906-1a4f8f95-17b6-47ef-bfe5-c1c702f0a893.mp4" controls="controls" style="max-width: 730px;">
</video>


## Description of the app
We cannot say that this is the best looking app in the world, but at least it perfectly does what it was built for: it parses a given .csv file and computes a univariate distribution of a variable. You will see an upgrade in homework 3 for sure!

# Research on app

CSV is a simple format for representing a rectangular array (matrix) of numeric and textual values. It an example of a “flat file” format. It is a delimited data format that has fields/columns separated by the comma character %x2C (Hex 2C) and records/rows/lines separated by characters indicating a line break. RFC 4180 stipulates the use of CRLF pairs to denote line breaks, where CR is %x0D (Hex 0D) and LF is %x0A (Hex 0A). Each line should contain the same number of fields. Fields that contain a special character (comma, CR, LF, or double quote), must be “escaped” by enclosing them in double quotes (Hex 22). An optional header line may appear as the first line of the file with the same format as normal record lines. This header will contain names corresponding to the fields in the file and should contain the same number of fields as the records in the rest of the file. CSV commonly employs US-ASCII as character set, but other character sets are permitted




