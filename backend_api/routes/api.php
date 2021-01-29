<?php

use App\Http\Controllers\CategoryController;
use App\Http\Controllers\ProductController;
use App\Http\Controllers\UserController;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| API Routes
|--------------------------------------------------------------------------
|
| Here is where you can register API routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| is assigned the "api" middleware group. Enjoy building your API!
|
*/

Route::middleware('auth:api')->get('/user', function (Request $request) {
    return $request->user();
});

Route::prefix('user')->group(function () {
    Route::get('getlist',[UserController::class,'getAllUser']);
    Route::post('create',[UserController::class,'createUser']);
    Route::post('update/{id}',[UserController::class,'updateUser']);
    Route::delete('delete/{id}',[UserController::class,'deleteUser']);
});

Route::prefix('categories')->group(function () {
    Route::get('all', [CategoryController::class, 'getAllCategory']);
    Route::post('create', [CategoryController::class, 'createCategory']);
    Route::post('update/{id}', [CategoryController::class, 'updateCategory']);
    Route::delete('delete/{id}', [CategoryController::class, 'deleteCategory']);
});


Route::prefix('product')->group(function () {
    Route::get('list', [ProductController::class, 'getAllProduct']);
    Route::post('create', [ProductController::class, 'createProduct']);
    Route::post('update/{id}', [ProductController::class, 'updateProduct']);
    Route::delete('delete/{id}', [ProductController::class, 'deleteProduct']);
    Route::post('upload', [ProductController::class, 'uploadImage']);
});
