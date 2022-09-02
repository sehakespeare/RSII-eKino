import 'dart:convert';
import 'dart:io';
import 'dart:async';
import 'package:ekinomobile/model/product.dart';
import 'package:ekinomobile/providers/base_provider.dart';
import 'package:http/http.dart';
import 'package:http/io_client.dart';
import 'package:flutter/foundation.dart';

class ProductProvider extends BaseProvider<Product> {
  ProductProvider() : super("Proizvodi");

  @override
  Product fromJson(data) {
    return Product.fromJson(data);
  }
}